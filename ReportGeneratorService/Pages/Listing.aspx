<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="ReportGeneratorService.Pages.Listing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div id="listingContainer" class="container mtxl">

            <div class="container mbxl">
                <div class="row">
                    <div class="span1 ">
                        <label class="text-right">Activity Name</label>
                    </div>
                    <div class="span2">
                        <input id="activityName" type="text" class="form-control input-medium" />
                    </div>
                    <div class="span1 ">
                        <label class="text-right">City Name</label>
                    </div>
                    <div class="span2">
                        <input id="cityName" type="text" class="form-control input-medium" />
                    </div>
                    <div class="span1 ">
                        <label class="text-right">Tag Name</label>
                    </div>
                    <div class="span2">
                        <input id="tagName" type="text" class="form-control input-medium" />
                    </div>
                    <div class="span2">
                        <button id="btnSearch" class="span6 btn btn-lg btn-primary btn-block" type="button">Search Itineraries</button>
                        <a></a>
                    </div>
                </div>
            </div>

            <div class="table-responsive hidden maxHeight">
                <table class="table table-bordered table-hover ">
                    <thead>
                        <tr>
                            <th class="text-center span1" title="click id to view details">Id</th>
                            <th class="text-center span3">Name</th>
                            <th class="text-center span2">Phone</th>
                            <th class="text-center span5">Address</th>
                            <th class="text-center span2">Compare</th>
                        </tr>
                    </thead>
                    <tbody id="listingTableBody">
                    </tbody>
                </table>
            </div>

        </div>
    </form>
</body>
</html>
