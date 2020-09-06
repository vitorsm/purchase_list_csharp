

$(document).ready(function () {
    const fields = [
        {
            fieldName: "Id",
            validation: null,
            onlyInEditMode: true
        }, {
            fieldName: "CreatedBy",
            validation: null,
            onlyInEditMode: true
        }, {
            fieldName: "CreatedAt",
            validation: null,
            onlyInEditMode: true
        }, {
            fieldName: "ModifiedAt",
            validation: null,
            onlyInEditMode: true
        }, {
            fieldName: "Name",
            validation: (value) => !!value,
            onlyInEditMode: false
        }
    ];

    const defaultErrorValueMessage = "The value is no valid";

    $("#create-product-button-id").click(() => {
        initCreationMode();
        setFieldsValidationOnChange();
    });

    $("#product-dialog-save-button-id").click(() => {
        showLoading(true);

        $.ajax({
            type: "POST",
            url: "Products/Create",
            contentType: "application/json",
            dataType: 'json',
            data: JSON.stringify(instantiateObject()),
            success: handleProductAdded
        });
    });



    function initCreationMode() {
        fields.filter(field => field.onlyInEditMode).forEach(field => {
            $("div[field-name='" + field.fieldName + "']").css("display", "none");
        });

        $(".modal-title").html("Create a product");
    }

    function initEditMode() {
        fields.forEach(field => {
            $("div[field-name='" + field.fieldName + "']").css("display", "block");
        });

        $(".modal-title").html("Edit a product");
    }

    function setFieldsValidationOnChange() {
        fields.filter(field => field.validation).forEach(field => {
            let inputQuery = "div[field-name='" + field.fieldName + "'] > input";
            let errorComponentQuery = "div[field-name='" + field.fieldName + "'] > span";

            fillValidationMessage($(inputQuery), field.validation, $(errorComponentQuery));

            $(inputQuery).keyup(() => {
                fillValidationMessage($(inputQuery), field.validation, $(errorComponentQuery));
            })
        });
    }

    function fillValidationMessage(element, validationFunction, errorMessageElement) {
        let value = element.val();
        let isValid = validationFunction(value);

        if (isValid) {
            errorMessageElement.html("");
        } else {
            errorMessageElement.html(defaultErrorValueMessage);
        }
    }

    function instantiateObject() {
        let strId = $("div[field-name='Name'] > input").val();
        let id = null;

        if (strId && isNaN(strId)) {
            id = parseInt(strId);
        }

        return {
            id: id,
            name: $("div[field-name='Name'] > input").val()
        };
    }

    function handleProductAdded(result) {
        console.log("handleProductAdded was called", result)
        let item = $("#product-list-item").children().first().children().first().clone();

        item.children().eq(0).html(result.name);
        item.children().eq(1).html(result.createdAt);
        item.children().eq(2).html(result.modifiedAt);

        $("#products-list-table").append(item);

        $('#product-crud-modal-id').modal('toggle');

        showLoading(false);
    }

    function showLoading(show) {
        if (show || show === undefined) {
            $("#product-dialog-loading").css("display", "block");
        } else {
            $("#product-dialog-loading").css("display", "none");
        }
    }

});
