//(function (window, $, undefined) {
$(document).ready(function () {
    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Views == null)
        window.Innventia.Views = {};

    window.Innventia.Views.LoginView = Backbone.View.extend({
        
        el: $('#loginContainer'),

        //model: window.Innventia.Models.LoginModel,

        render: function () {

            var self = this;
            
            //var myModel = window.Innventia.Models.LoginModel.extend({
            //    urlRoot: '/IMSapi/login'
            //});
            //this.model = new myModel();


            //this.model = new (window.Innventia.Models.LoginModel.extend({ urlRoot: function () { return '/IMSapi/login'; } }));


            this.collection = new window.Innventia.Collections.LoginCollection([
                { id: 1 }, { id: 2 }, { id: 3 }
            ]);

            //            this.collection = new window.Innventia.Collections.LoginCollection();



            //this.collection.model.set('id', 3);
            this.collection.models[1].fetch().success(function (data) {
                self.embedHtml(data);
            });

            //this.model.set('id', 3);
            ////this.model.set('url', '/IMSapi/login');
            //this.model.fetch().success(function (data) {
            //    self.embedHtml(data);
            //});
        },

        initialize: function () {
            this.bindEvents();
        },

        embedHtml: function (data) {
            var html = Mustache.render("{{#data}}<tr> <td class='text-center'>{{#Id}}{{Id}}{{/Id}}</td> <td class='text-center'>{{#Name}}{{Name}}{{/Name}}</td> <td class='text-center'>{{#ChainCode}}{{ChainCode}}{{/ChainCode}}</td> <td class='text-center'>{{#Address}}{{Address}}{{/Address}}</td> </tr>{{/data}}", { data: data });
            $('#listingTableBody', this.el).html(html);
            $('#email').val(data.Address);
        },

        bindEvents: function () {

            var self = this;

            $('#loginNav', self.el).click(function () {

                $(this).parent().addClass('active');
                $('#registerNav', self.el).parent().removeClass('active');
                $('#signInForm').fadeIn(500, function () {
                    $(this).removeClass('hidden');
                });
                $('#registerForm').fadeOut(500, function () {
                    $(this).addClass('hidden');
                });

            });

            $('#registerNav', self.el).click(function () {
                $(this).parent().addClass('active');
                $('#loginNav', self.el).parent().removeClass('active');
                $('#registerForm').fadeIn(500, function () {
                    $(this).removeClass('hidden');
                });
                $('#signInForm').fadeOut(500, function () {
                    $(this).addClass('hidden');
                });
            });

            $('#btnSignIn').click(function () {
                self.render();
            });
        }
    });


    var loginView = new window.Innventia.Views.LoginView();
});

//})(window, jQuery);