﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#table').DataTable({
        "language": {
            search: "_INPUT_",
            searchPlaceholder: "Recherche",
            paginate: { first: "Premier", previous: "Précedent", next: "Suivant", last: "Dernier" },
        },
        

    }); 



});