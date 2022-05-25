$(document).ready(function () {
    // Initialization  
   
    var firstname = "A";

    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/USER/SearchName',
            data: { firstname: firstname },
            success:
                function (response) {
                    // Generate HTML table.  
                    convertJsonToHtmlTable(JSON.parse(response), $("#TableId"));
                },
            error:
                function (response) {
                    alert("Error: " + response);
                }
        });  
...   
  
});
