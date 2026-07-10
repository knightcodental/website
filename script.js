document.addEventListener("DOMContentLoaded", function () {

    const button = document.querySelector("button");

    if (button) {
        button.addEventListener("click", function () {
            alert("Thank you for visiting Knight Co Dental!\n\nPlease contact us for our latest Dental Instruments.");
        });
    }

    console.log("Knight Co Dental Website Loaded Successfully");

});