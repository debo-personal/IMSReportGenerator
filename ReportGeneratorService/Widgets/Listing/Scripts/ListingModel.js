$(document).ready(function () {

    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Models == null)
        window.Innventia.Models = {};

    window.Innventia.Models.ListingModel = Backbone.Model.extend({
        defaults: {
            Id: 0,
            Name: '',
            Phone: '',
            Address: ''
        }
    });
});