(function () {
    var form = document.getElementById("contact-form");

    form.addEventListener("submit", event => {
        // make sure the browser doesn't submit the form as usual
        event.preventDefault();

        // read the form.elements fields
        var formData = {
            email: form.elements.Email.value,
            message: form.elements.Message.value
        };

        // process the collected data
        fetch("/contact/submit", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(formData)
        }).then(response => {
            if (response.ok) {
                showAlert("alert-success");
            } else {
                showAlert("alert-error");
            }
        }).catch(() => {
            showAlert("alert-error");
        });
    });

    function showAlert(alertId) {
        var alertElement = document.getElementById(alertId);
        alertElement.classList.remove("d-none");
    }
})();