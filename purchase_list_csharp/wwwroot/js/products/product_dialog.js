

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
        $.ajax({
            type: "POST",
            url: "Products/Create",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify({ "name": $("div[field-name='Name'] > input").val() })
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

});
