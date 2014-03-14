$(document).ready(function () {

    if (window.Innventia == null)
        window.Innventia = {};

    if (window.Innventia.Templates == null)
        window.Innventia.Templates = {};

    window.Innventia.Templates.ActivityListingTemplate = "{{#data}}<tr> <td class='text-center'>{{#Id}}{{Id}}{{/Id}}</td> <td class='text-center'>{{#Name}}{{Name}}{{/Name}}</td> <td class='text-center'>{{#Phone}}{{Phone}}{{/Phone}}</td> <td class='text-center'>{{#Address}}{{Address}}{{/Address}}</td> <td class='text-center'><a class='pointer compare' data-Id = {{Id}}>Compare</a></td> </tr>{{/data}}";
});