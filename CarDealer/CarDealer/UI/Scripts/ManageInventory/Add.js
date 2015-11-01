$(document).ready(function () {

    var uri = '/services/vehicle/';

    $("#ModelFormGroup").hide();
    $("#AddSuccess").hide();
    $("#EditSuccess").hide();
    GetMakes($("#editMakeID"));

    $(".vEdit").click(function () {
        var id = $(this).attr("id");
        var form = $("#EditCarForm");
        $.getJSON(uri + "Edit/" + id)
            .done(function (data) {
                form.find("#editVinNo").val(data.VinNo);
                form.find("#editModelYear").val(data.ModelYear);
                form.find("#editIsNew").val(data.IsNew);
                form.find("#editMileage").val(data.Mileage);
                form.find("#editImageURL").val(data.ImageUrl);
                form.find("#editSellingPrice").val(data.SellingPrice);
                form.find("#editMakeID").val(data.MakeID);
                $.getJSON(uri + "Models/" + data.MakeID)
                    .done(function(data) {
                        $.each(data, function(index, model) {
                            $('#editModelID').append(CreateOption(model.ModelName, model.ModelID));
                            $("#editModelID").val(model.ModelID);
                        });
                    });
                var avail = 0;
                if (data.IsAvailable === true) {
                    avail = 1;
                }
                form.find("#editIsAvailable").val(avail);
            });
    });

    $('#AddCarModal').on('shown.bs.modal', function (e) {
        if (!$("#MakeID").hasClass("loaded")) {
            GetMakes($("#MakeID"), false);
            $("#MakeID").addClass("loaded");
        }
    });
    
    function GetMakes(selectList) {
        $.getJSON(uri + "Makes")
            .done(function (data) {
                $.each(data, function (index, make) {
                    selectList.append(CreateOption(make.MakeName, make.MakeID));
                });
            });

    };

    var currentModelSelection;

    $('#editMakeID').on('change', function () {

        if (currentModelSelection === null || $(this).val() !== currentModelSelection) {

            currentModelSelection = $(this).val();
            
            $.getJSON(uri + "Models/" + $(this).val())
            .done(function (data) {
                $.each(data, function (index, model) {
                    $('#editModelID').append(CreateOption(model.ModelName, model.ModelID));
                });
            });
        }
    });

    $('#MakeID').on('change', function () {

        if ($(this).val() !== "Select a Make") {
            $("#ModelFormGroup").show();
        } else {
            $("#ModelFormGroup").hide();
        }

        if (currentModelSelection === null || $(this).val() !== currentModelSelection) {

            currentModelSelection = $(this).val();

            $('#ModelID').empty();
            $('#ModelID').append("<option>Select a Model</option>");

            $.getJSON(uri + "Models/" + $(this).val())
            .done(function (data) {
                $.each(data, function (index, model) {
                    $('#ModelID').append(CreateOption(model.ModelName, model.ModelID));
                });
            });
        }
    });


    function CreateOption(name, id) {
        return "<option value='" + id + "'>" + name + "</option>";
    }

    $("#AddCarForm").on("submit", function (e) {

        e.preventDefault();
        var $form = $(this);
        if (!$form.valid()) return;
        //If successful, this will store the values for the car that we append to the list
        var newID = -1;

        $.ajax({
            type: "POST",
            url: uri + "Add",
            data: $form.serialize(),
            dataType: "json",
            success: function (data) {

                var car = {
                    VehID: data.VehID,
                    ModelYear: data.ModelYear,
                    MakeName: $form.find("#MakeID :selected").text(),
                    ModelName: $form.find("#ModelID :selected").text(),
                    Trim: data.Trim,
                    Mileage: data.Mileage,
                    SellingPrice: data.SellingPrice,
                    IsAvailSmartProp: $form.find("#IsAvailable :selected").text(),

                }

                if (car.VehID !== -1) {
                    $("#inventoryTable").append("<tr>" +
                        "<td>" + car.VehID + "</td>" +
                        "<td>" + car.ModelYear + "</td>" +
                        "<td>" + car.MakeName + "</td>" +
                        "<td>" + car.ModelName + "</td>" +
                        "<td>" + car.Trim + "</td>" +
                        "<td>" + car.Mileage + "</td>" +
                        "<td>" + car.SellingPrice + "</td>" +
                        "<td>" + car.IsAvailSmartProp + "</td>" +
                        "<td><a href='/ManageInventory/Edit/" + car.VehID + "'>Edit</a> |" +
                        " <a href='/ManageInventory/Details/" + car.VehID + "'>Delete</a> |" +
                        " <a href='/Crm/Details/" + car.VehID + "'>Details</a></td></tr>");
                }

                $("#ModelFormGroup").hide();
                $("#AddCarForm").hide();
                $("#AddSuccess").show();

                
            }
        });
    });


    $("#resetForm").click(function () {

        //Other options to clear the form that don't work 100% as intended.
        //$('#AddCarForm').each(function () {
        //    this.reset();
        //});
        //$form.find(".form-control").val("");
        //AddCarFormValidator.resetForm();
        $("#AddCarForm")[0].reset();
        $(".has-success").removeClass("has-success");

        $("#AddSuccess").hide();
        $("#AddCarForm").show();
    });

    //VALIDATION

    jQuery.validator.addMethod("notEqual", function (value, element, param) {
        return this.optional(element) || value != param;
    }, "Please select from the list.");

    var AddCarFormValidator = $('#AddCarForm').validate({
        rules: {
            VinNo: { required: true },
            ModelYear: { required: true },
            IsNew: { required: true },
            Mileage: { required: true },
            ImageURL: { required: true },
            SellingPrice: { required: true },
            MakeID: {
                required: true,
                notEqual: "Select a Make"
            },
            ModelID: {
                required: true,
                notEqual: "Select a Model"
            },
            IsAvailable: { required: true },
        },
        messages: {
            VinNo: "Required field",
            ModelYear: "Required field",
            IsNew: "Required field",
            Mileage: "Required field",
            ImageURL: "Required field",
            SellingPrice: "Required field",
            //MakeID: "Required field",
            //ModelID: "Required field",
            IsAvailable: "Required field",
        }
    })
});