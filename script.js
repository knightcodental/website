console.log("Knight Co Dental Website Loaded");

document.addEventListener("DOMContentLoaded", function () {
  const button = document.querySelector("button");

  if (button) {
    button.addEventListener("click", function () {
      alert("Welcome to Knight Co Dental!");
    });
  }
});
