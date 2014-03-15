(function (window, $, undefined) {


    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Views == null)
        window.Innventia.Views = {};

    window.Innventia.Views.LoginView = Backbone.View.extend({

        template: Innventia.Templates.HotelListingTemplate,

        el: $('#listingContainer'),

        model: new (window.Innventia.Models.ListingModel.extend({
            urlRoot: '/IMSapi/HotelListing'
        })),

        collection: new window.Innventia.Collections.ListingCollection(),

        render: function () {
            this.embedHtml();
        },

        initialize: function () {
            this.bindEvents();
        },

        embedHtml: function () {
            var data = [];
            $.each(this.collection.models, function (index, item) {
                data.push(item.attributes);
            });

            var html = Mustache.render(this.template, { data: data });
            $('.table-responsive', this.el).removeClass('hidden');
            $('#listingTableBody', this.el).html(html);
            this.bindEvents();
        },

        bindEvents: function () {

            var self = this;

            $('#btnSearch').unbind('click').click(function () {
                self.fetchActivities();
            });

            $('.compare', this.el).unbind('click').click(function () {
                self.fetchActivityDetails($(this).data('id'));
            });

        },

        fetchActivities: function () {

            var self = this;
            this.collection.fetch({
                data: {

                    ActivityName: '',
                    CityName: '',
                    TagName: '',
                    Top: 50,
                    Skip: 50

                }
            }).done(function (apiResponse) {
                self.collection.set(apiResponse.HotelRows);
                self.render();
            });
        },

        fetchActivityDetails: function (id) {
            console.log(_.where(this.collection.toJSON(), { Id: id }));
        }
    });

})(window, jQuery);