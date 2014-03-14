$(document).ready(function () {

    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Models == null)
        window.Innventia.Models = {};

    window.Innventia.Models.LoginModel = Backbone.Model.extend({
        url : ''
    });
});