﻿/*
Copyright (c) 2003-2011, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function(config) {
    // Define changes to default configuration here. For example:
    config.language = 'vi';
    config.enterMode = CKEDITOR.ENTER_BR;
    config.extraPlugins = 'xml';
    config.htmlEncodeOutput = false;
    config.entities = false;
    //config.removePlugins = 'elementspath,enterkey,entities,forms,pastefromword,specialchar,horizontalrule,wsc';
    config.skin = 'office2003';
    //    CKEDITOR.config.toolbar = [
    //       ['Styles', 'Format', 'Font', 'FontSize'],

    //       ['Bold', 'Italic', 'Underline', 'StrikeThrough', '-', 'Undo', 'Redo', '-', 'Cut', 'Copy', 'Paste', 'Find', 'Replace', '-', 'Outdent', 'Indent', '-', 'Print'],
    //       '/',
    //       ['NumberedList', 'BulletedList', '-', 'JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
    //       ['Image', 'Table', '-', 'Link', 'Flash', 'Smiley', 'TextColor', 'BGColor']//, 'Source'
    //    ];
};
