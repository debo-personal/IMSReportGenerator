//(function (window, $, undefined) {
$(document).ready(function () {
    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Views == null)
        window.Innventia.Views = {};

    window.Innventia.Views.LoginView = Backbone.View.extend({
        el: $('#loginContainer'),

        render: function (data) {
            console.log(data);
        },

        initialize: function () {
            this.bindEvents();
            this.getPassword();
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

            });
        },

        getPassword: function () {
            var that = this;
            $.ajax({
                url: 'http://localhost:55596/api/values',
                dataType: "json",
                type: 'GET',
                contentType: 'application/json; charset=UTF-8',
                success: function (data) {
                    that.render(data);
                },
                error: function (status) {
                    console.log(status);
                }
            });
        }
    });


    var loginView = new window.Innventia.Views.LoginView();
});

//})(window, jQuery);