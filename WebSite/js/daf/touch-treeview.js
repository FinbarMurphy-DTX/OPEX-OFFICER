/*eslint eqeqeq: ["error", "smart"]*/
/*!
* Touch UI - Tree View
* Copyright 2023-2024 Code On Time LLC; Licensed MIT; http://codeontime.com/license
*/

(function () {
    var _app = $app,
        _input = _app.input,
        _touch = _app.touch,
        $document = $(document),
        resources = Web.DataViewResources,
        booleanDefaultItems = resources.Data.BooleanDefaultItems,
        getBoundingClientRect = _app.clientRect,
        // core variables

        // html utilities
        htmlUtilities = _app.html,
        htmlTag = htmlUtilities.tag,
        div = htmlUtilities.div,
        span = htmlUtilities.span,
        $htmlTag = htmlUtilities.$tag,
        $p = htmlUtilities.$p,
        $div = htmlUtilities.$div,
        $span = htmlUtilities.$span,
        $a = htmlUtilities.$a,
        $i = htmlUtilities.$i,
        $li = htmlUtilities.$li,
        $ul = htmlUtilities.$ul;

    _touch.treeView = function (method, options, resolve, reject) {
        if (resolve) {
            _touch.treeView.ready = true;
            resolve();
            if (!method)
                return;
        }
        if (typeof method != 'string') {
            options = method;
            method = 'show';
        }
        var nodes = options.nodes;
        if (nodes instanceof Promise) {
            nodes.then(hierarchy => {
                options.nodes = hierarchy.nodes || {};
                _touch.treeView(method, options);
            })
        }
        else {
            traverseNodes(nodes);
            var treeView = options.treeView,
                trackSelection = options.trackSelection;
            if (treeView) {
                nodes = options.nodes || treeView.data('nodes');
                createNodes($ul().appendTo(treeView.empty()), nodes, null);
            }
            else {
                treeView = $div('app-treeview app-has-scrollbars').attr({ 'data-hierarchy': options.type, 'tabindex': -1 }).data({ nodes, trackSelection });
                createNodes($ul().appendTo(treeView), nodes, null);
                if (options.container)
                    treeView.appendTo(options.container);
                if (options.before)
                    treeView.insertBefore(options.before);
                if (options.after)
                    treeView.insertAfter(options.after);
            }
            treeView.toggleClass('app-treeview-noicons', options.icons === false);
            var selectedNodePath = options.path || (trackSelection ? _app.userVar('treeview.' + options.type) : null);
            if (selectedNodePath) {
                navigating(true);
                navigateToNode(treeView.find('ul'), selectedNodePath);
            }
        }

    };

    function traverseNodes(nodes, parent) {
        for (var nodeName in nodes) {
            var n = nodes[nodeName];
            n.name = nodeName;
            if (parent)
                n.parent = parent;
            if (n.nodes)
                traverseNodes(n.nodes, n);
        }
    }

    function navigating(state) {
        var currentState = _touch.treeView._navigating;
        if (arguments.length && currentState != state) {
            _touch.treeView._navigating = state;
            _touch.activePage('.app-treeview').css('visibility', state ? 'hidden' : '');
        }
        return currentState;
    }

    function navigateToNode(container, nodePath) {
        if (typeof nodePath == 'string') {
            var pathInfo = nodePath.match(/^(.+?)\:\/\/(.+)$/);
            if (pathInfo) {
                var context = _touch.treeView.context(container);
                if (context.hierarchy.endsWith('.' + pathInfo[1]))
                    nodePath = pathInfo[2];
                else {
                    navigating(false);
                    context.eventName = 'navigate';
                    context.path = nodePath;
                    var navigateEvent = $.Event('treeview.app', { treeView: context });
                    $(document).trigger(navigateEvent);
                    if (navigateEvent.isDefaultPrevented())
                        return;
                    else
                        _touch.notify({ text: `Unable to navigate to ${nodePath}`, duration: 'long' });
                }
            }
            if (nodePath.match(/^\./)) {
                navigating(false);
                _touch.propGrid.select(nodePath.substring(1));
                return;
            }
            nodePath = nodePath.split(/\//g);
            nodePath.forEach((n, index) => {
                if (!n.match(/^\./))
                    n = n.toLowerCase();
                nodePath[index] = decodeURIComponent(n);
            });
        }
        if (nodePath.length) {
            var selectedNode;
            container.find('>li').each(function () {
                var node = $(this);
                var nodeId = node.data('nodeId');
                if (nodeId === nodePath[0]) {
                    selectedNode = node;
                    return false;
                }
            });
            if (selectedNode) {
                if (!nodePath._cleared) {
                    selectedNode.closest('.app-treeview').find('.app-selected').removeClass('app-selected');
                    nodePath._cleared = true;;
                }
                nodePath.splice(0, 1);
                var doSelect = true;
                if (nodePath.length === 1 && nodePath[0].match(/^\./)) {
                    var dataView = _touch.dataView();
                    _app.userVar(`${dataView._survey.context.instance}.navigate`, nodePath[0]);
                }
                else if (nodePath.length) {
                    doSelect = false;
                    if (selectedNode.is('.app-collapsed')) {
                        selectedNode.find('>.app-node>.app-toggle').trigger('vclick');
                    }
                    navigateToNode(selectedNode.find('ul'), nodePath);
                }
                if (doSelect) {
                    var nodeText = selectedNode.data('navigating', true).find('>.app-node').trigger('vclick');
                    selectedNode.removeData('navigating');
                    var anchor = nodeText.find('.app-anchor')[0];
                    if (anchor)
                        if (_touch.busy() || navigating())
                            anchor.scrollIntoView({ block: 'center', behavior: 'instant' });
                        else {
                            // TODO: remove this code. Navigation is always instant.
                            var treeViewRect = _app.clientRect(nodeText.closest('.app-treeview'));
                            var nodeTextRect = _app.clientRect(nodeText);
                            if (!(nodeTextRect.top > treeViewRect.top && nodeTextRect.bottom < treeViewRect.bottom)) {
                                //setTimeout(() => {
                                //    anchor.scrollIntoView({ block: 'center', behavior: 'smooth' })
                                //}, 32);
                                _touch.pageShown(() => {
                                    setTimeout(() => {
                                        anchor.scrollIntoView({ block: 'center', behavior: 'smooth' })
                                    });
                                });
                            }
                        }
                    navigating(false);
                }

            }
            else {
                var loading = container.find('>.app-loading');
                if (loading.length)
                    loading.data('navigate', nodePath);
                else
                    navigating(false);
            }
        }
    }

    function findParentNodeTemplate(nodeTemplate, nodeName) {
        var result = null;
        if (nodeTemplate) {
            if (nodeTemplate.name == nodeName)
                result = nodeTemplate;
            if (!result) {
                if (nodeTemplate.nodes)
                    result = nodeTemplate.nodes[nodeName];
                if (!result || result.clone)
                    result = findParentNodeTemplate(nodeTemplate.parent, nodeName);
            }
        }
        return result;
    }

    function mapNodeProps(template) {
        var map = {};
        for (var key in template)
            map[key] = template[key];
        return map;
    }

    function createNodes(parent, nodes, nodeData, placeholder) {
        var parentData = null;
        for (var nodeName in nodes) {
            var masterNodeTemplate = nodes[nodeName];
            var nodeTemplate = mapNodeProps(masterNodeTemplate);
            if (nodeTemplate.clone) {
                var parentTemplate = findParentNodeTemplate(nodeTemplate.parent, nodeTemplate.clone);
                if (parentTemplate) {
                    parentTemplate = mapNodeProps(parentTemplate);
                    for (var key in nodeTemplate)
                        if (!key.match(/^(clone|name|parent)$/))
                            parentTemplate[key] = nodeTemplate[key];
                    nodeTemplate = parentTemplate;
                }
            }
            var instanceData = nodeData;
            try {
                if (!instanceData && !nodeTemplate.iterate && nodeTemplate.inherit) {
                    if (!parentData) {
                        parentData = parent.closest('li').data();
                        instanceData = {};
                        instanceData[parentData.nodeName] = parentData.nodeData;
                        parentData = instanceData;
                    }
                    instanceData = parentData;
                }

                var text = _app.eval(nodeTemplate.text, instanceData) || _app.prettyText(nodeName, true);
                var id = nodeTemplate.id ? _app.eval(nodeTemplate.id, instanceData) : text;
                if (nodeTemplate.text == null || nodeTemplate.text === text)
                    id = nodeName;
                var nodeType = nodeTemplate.type;
                var li = $li().attr({ 'data-type': nodeType }).data({ nodeName, nodeTemplate, nodeData, nodeId: encodeURIComponent(id.toLowerCase()) });
                if (placeholder)
                    li.insertBefore(placeholder);
                else
                    li.appendTo(parent);
                var textSpan = $span('app-node').appendTo(li);
                var anchor = $span('app-anchor').appendTo(textSpan);
                var textNode = $span('app-text').appendTo(textSpan).text(text);
                if (nodeTemplate.textMuted) {
                    var mutedText = _app.eval(nodeTemplate.textMuted, instanceData);
                    if (mutedText != null)
                        $span('app-muted').appendTo(textSpan).text(mutedText);
                }
                var icon = nodeTemplate.icon;
                if (icon) {
                    icon = _app.eval(icon, instanceData);
                    if (typeof icon == 'string') {
                        var materialIcon = icon.match(/^material\-icon\-(.+)$/);
                        if (materialIcon)
                            iconElem = $htmlTag('i', 'app-icon material-icon').text(materialIcon[1].replace(/\W/i, '_')).appendTo(textNode);
                        else if (icon.match(/^[\w\-\_]+$/) || icon.match(/material\-symbol/))
                            textSpan.addClass(icon);
                    }
                }
                if (nodeTemplate.iterate && nodeData == null) {
                    textSpan.text('Loading...');
                    li.addClass('app-loading');
                    var parentNode = parent.closest('li');
                    if (!parentNode.length || parentNode.is('.app-expanded')) {
                        createNodesFromTemplate(nodeName, nodeTemplate, parent, li);
                    }
                }
                else {
                    var tooltip = nodeTemplate.tooltip;
                    if (typeof tooltip == 'string')
                        textNode.attr('data-title', _app.eval(tooltip, instanceData));
                    var children = nodeTemplate.nodes;
                    var terminal = nodeTemplate.terminal;
                    if (typeof terminal == 'string')
                        terminal = _app.eval(terminal, instanceData);

                    if (children) {
                        if (terminal)
                            children = null;
                    }
                    else if (terminal != null && !terminal)
                        children = [nodeTemplate];
                    if (children) {
                        li.addClass(nodeTemplate.expanded ? 'app-expanded' : 'app-collapsed');
                        $span('app-toggle').appendTo(textSpan);
                        createNodes($ul().appendTo(li), children);
                    }
                }

            } catch (ex) {
                _touch.notify({ text: ex.message + ': \n' + JSON.stringify(clearParentOfNode(nodeTemplate), null, 2), duration: 'long' });
                throw ex;
            }

        }
    }

    function clearParentOfNode(nodeTemplate) {
        nodeTemplate.parent = null
        if (nodeTemplate.nodes)
            for (var key in nodeTemplate.nodes)
                clearParentOfNode(nodeTemplate.nodes[key]);
        return nodeTemplate;
    }

    function createNodesFromTemplate(nodeName, nodeTemplate, parent, li) {
        var e = triggerTreeViewEvent('iterate', li);
        if (e.isDefaultPrevented()) {
            li.remove();
            return;
        }
        var fetchNodeRequest = e.treeView.result;
        if (!(fetchNodeRequest instanceof Promise)) {
            if (!Array.isArray(fetchNodeRequest))
                fetchNodeRequest = [fetchNodeRequest];
            fetchNodeRequest = Promise.resolve(fetchNodeRequest);
        }
        fetchNodeRequest
            .then(list => {
                var nodeInstance = {};
                nodeInstance[nodeName] = nodeTemplate;
                list.forEach(nodeData => {
                    createNodes(parent, nodeInstance, nodeData, li);
                });
                var navigate = li.data('navigate');
                li.remove(); // remove the first temlate item
                if (!list.length && !parent.find('.app-node').length)
                    parent.closest('li').removeClass('app-expanded').find('.app-node .app-toggle').remove();
                if (navigate)
                    navigateToNode(parent, navigate);
                else
                    scrollExpandedChildrenIntoView(parent.parent());
            })
            .catch(ex => {
                _touch.notify({ text: ex.errors ? ex.errors[0].message : ex.message, duration: 'long' });
                throw ex;
            });
    }

    function iterateNodes(startElem, path, callback) {
        var targetElem = startElem;
        var targetData;
        var rawSelector = path.match(/^(.+?)(\/|$)/);
        if (rawSelector) {
            var nodes = [];
            var selector = rawSelector[1].match(/^(\w+\:+)?(.+)$/);
            if (selector[1] === 'ancestor::') {
                targetElem = targetElem.parent().closest('li');
                while (targetElem.length) {
                    targetData = targetElem.data();
                    if (targetData.nodeName === selector[2]) {
                        nodes.push(targetElem);
                        break;
                    }
                    targetElem = targetElem.parent().closest('li');
                }
            }
            else {
                var children = targetElem.find('> ul > li');
                targetElem = null;
                children.each(function () {
                    var child = $(this);
                    targetData = child.data();
                    if ((!selector[1] || selector[1] === 'name::') && targetData.nodeName === selector[2] ||
                        selector[1] && targetData.nodeData && targetData.nodeData[selector[1].substring(0, selector[1].length - 1)] == selector[2]) {
                        nodes.push(child);
                    }
                });
            };
            if (nodes.length) {
                path = path.substring(rawSelector[0].length);
                nodes.forEach(n =>
                    iterateNodes(n, path, callback)
                );
            }
        }
        else {
            callback(targetElem);
        }
    }

    function replaceRelatedNode(target, nodeData) {
        var data = target.data();
        replaceNode(
            {
                nodeElem: target,
                node: data.nodeTemplate,
                nodeName: data.nodeName,
                nodeData: data.nodeData
            },
            nodeData,
            { related: false });
    }

    function replaceNode(nodeElem, nodeData, options) {
        if (!options)
            options = {};
        var treeView = nodeElem;
        if (!('nodeName' in nodeElem && 'nodeData' in nodeElem))
            treeView = _touch.treeView.context(nodeElem);
        nodeElem = treeView.nodeElem;
        var replaceLock = nodeElem.data('replaceLock');
        if (!replaceLock)
            nodeElem.data('replaceLock', true);
        // replace the related nodes
        if (options.related !== false) {
            (treeView.node.related || []).forEach(related => {
                if (typeof related == 'string') {
                    related = { path: related };
                }
                var relatedPath = _app.eval(related.path, nodeData);
                iterateNodes(nodeElem, relatedPath, target => {
                    var e = triggerTreeViewEvent('get', target);
                    var getResult = e.treeView.result;
                    if (getResult instanceof Promise)
                        getResult.then(result => {
                            replaceRelatedNode(target, result);
                        });
                    else
                        replaceRelatedNode(target, getResult);
                });
            });
        }
        // replace itself to provide instant feedback
        if (!replaceLock) {
            var nodeTemplate = {};
            nodeTemplate[treeView.nodeName] = treeView.node;
            var selectedChild = nodeElem.find('.app-selected');
            var oldNode = nodeElem.find('> .app-node');
            var tempList = $ul();
            _touch.treeView.createNodes(tempList, nodeTemplate, nodeData);
            var newNodeElem = tempList.children().insertAfter(nodeElem).toggleClass('app-selected', nodeElem.is('.app-selected'));
            if (selectedChild.length) {
                var data = newNodeElem.data('nodeData');
                nodeElem.data('nodeData', data);
                newNodeElem.find('> .app-node').insertAfter(oldNode);
                newNodeElem.remove();
                oldNode.remove();
                nodeElem.removeData('replaceLock');
            }
            else
                nodeElem.remove();
        }
    }

    $(document)
        .on('vclick', '.app-toggle', e => {
            if (!_input.valid())
                return;
            var li = $(e.target).closest('li');
            if (li.is('.app-expanded'))
                li.removeClass('app-expanded').addClass('app-collapsed');
            else {
                li.removeClass('app-collapsed').addClass('app-expanded');
                var scrollIntoView = true;
                li.find('> ul > li.app-loading').each(function () {
                    var liTemplate = $(this),
                        liData = liTemplate.data();
                    createNodesFromTemplate(liData.nodeName, liData.nodeTemplate, liTemplate.parent(), liTemplate);
                    scrollIntoView = false;
                });
                if (scrollIntoView)
                    scrollExpandedChildrenIntoView(li);
            }
            return false;
        })
        .on('vclick', '.app-treeview li span', e => {
            var target = $(e.target);
            if (!_input.valid())
                return;
            var li = target.closest('li');
            if (li.is('.app-loading'))
                return false;
            if (!target.is('.app-toggle') && _touch.dblClick($(target))) {
                li.find('> .app-node .app-toggle').trigger('vclick');
                return false;
            }
            if (e.isDefaultPrevented() || li.is('.app-selected'))
                return false;
            var treeview = target.closest('.app-treeview');
            var li = target.closest('li');
            treeview.find('.app-selected').removeClass('app-selected');
            li.addClass('app-selected');
            var nodeElem = target.closest('.app-node');
            var scrollBlock = null;
            if (!navigating() && !li.data('navigating')) {
                var nodeRect = _app.clientRect(nodeElem);
                var scrollableRect = _app.clientRect(li.closest('.app-treeview'));
                if (nodeRect.bottom > scrollableRect.bottom)
                    scrollBlock = 'end';
                else if (nodeRect.top < scrollableRect.top)
                    scrollBlock = 'start';
            }
            if (scrollBlock)
                nodeElem[0].scrollIntoView({ block: scrollBlock, behavior: 'smooth' });
            setTimeout(triggerTreeViewEvent, scrollBlock ? 16 * 6 : 0, 'select', li);
            return false;
        })
        .on('vclick', '[data-studio-link]', e => {
            if (!_input.valid())
                return;
            var target = $(e.target),
                link = target.closest('[data-studio-link]').attr('data-studio-link');
            if (link) {
                var hiearchy = target.closest('.app-propgrid').find('[data-hierarchy]');
                navigating(true);
                navigateToNode(hiearchy.find('>ul'), link);
            }
            return false;
        });

    function triggerTreeViewEvent(eventName, nodeElem) {
        var treeView = _touch.treeView.context(nodeElem);
        treeView.eventName = eventName;
        if (eventName === 'select' && treeView.treeView.data('trackSelection'))
            _app.userVar('treeview.' + treeView.hierarchy, treeView.nodePath);
        var e = $.Event('treeview.app', { treeView });
        if (eventName === 'iterate') {
            if (treeView.node.when) {
                var iterate = _app.eval(treeView.node.when, treeView.nodeData);
                if (!iterate) {
                    e.preventDefault();
                    return e;
                }
            }
        }
        $(document).trigger(e);
        return e;
    }

    _touch.treeView.data = function (type) {
        var obj;
        if (type) {
            if (!Array.isArray(type))
                type = type.split(/\s*,\s*/g);
        }
        else
            obj = {};
        _touch.activePage('.app-treeview .app-selected:first .app-node').parents('li').each(function () {
            var node = $(this),
                nodeType = node.attr('data-type'),
                nodeData = node.data('nodeData');
            if (type) {
                type.forEach(t => {
                    if (t === nodeType)
                        obj = nodeData;
                });
                if (obj)
                    return false;
            }
            else if (nodeType)
                obj[nodeType] = nodeData || {};
        });
        return obj;
    };

    _touch.treeView.context = function (nodeElem) {
        if (!nodeElem)
            nodeElem = _touch.activePage('.app-treeview .app-selected:first');
        var treeView = nodeElem.length ? nodeElem.closest('.app-treeview') : _touch.activePage('.app-treeview'),
            hierarchy = treeView.attr('data-hierarchy'),
            nodeName = nodeElem.data('nodeName'),
            node = nodeElem.data('nodeTemplate'),
            nodeData,
            elem = nodeElem,
            nodePath = [];
        while (elem.length) {
            nodePath.splice(0, 0, elem.is('.app-loading') ? '*' : elem.data('nodeId'));
            if (nodeData == null)
                nodeData = elem.data('nodeData');
            elem = elem.parent().closest('li');
        }
        return {
            hierarchy,
            treeView,
            node,
            nodeName,
            nodePath: nodePath.join('/'),
            nodeData,
            nodeElem
        };
    };

    _touch.treeView.createNodes = createNodes;
    _touch.treeView.replaceNode = replaceNode;

    function scrollExpandedChildrenIntoView(li) {
        if (!navigating()) {
            var liRect = _app.clientRect(li);
            var treeView = li.closest('.app-treeview');
            var treeViewRect = _app.clientRect(treeView);
            var ul = li.find('> ul');
            var ulRect = _app.clientRect(ul);
            if (ulRect.bottom > treeViewRect.bottom) {
                var block = 'start';
                var scrollTarget = li;
                if (liRect.height < treeViewRect.height) {
                    scrollTarget = ul;
                    block = 'end';
                }
                if (scrollTarget.length)
                    scrollTarget[0].scrollIntoView({ block, behavior: 'smooth' });
            }
        }
    }

})();