$(document).ready(function () {

    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Collections == null)
        window.Innventia.Collections = {};

    window.Innventia.Collections.LoginCollection = Backbone.Collection.extend({
        url: '/IMSapi/login',
        model: window.Innventia.Models.LoginModel
    });
});