$(document).ready(function () {

    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Collections == null)
        window.Innventia.Collections = {};

    window.Innventia.Collections.ListingCollection = Backbone.Collection.extend({
        url: '/IMSapi/HotelListing',
        model: window.Innventia.Models.ListingModel
    });
});