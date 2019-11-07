(function () {
    var form = document.getElementById("contact-form");

    form.addEventListener("submit", event => {
        event.preventDefault();

        var formData = {
            email: form.elements.Email.value,
            message: form.elements.Message.value
        };

        fetch("/contact/submit", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(formData)
        }).then(() => {
            showAlert("alert-success");
        }).catch(() => {
            showAlert("alert-error");
        });
    });

    function showAlert(alertId) {
        var alertElement = document.getElementById(alertId);
        alertElement.classList.remove("d-none");
    }
})();