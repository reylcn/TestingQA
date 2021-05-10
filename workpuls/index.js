const form = document.getElementById("form");
const inputs = form.querySelectorAll("input, select, textarea");
const submit = document.getElementById("submit");

form.addEventListener("keyup", () => {
  let filled = true;
  for (const input of inputs) {
    if (input.required && !input.value.length) {
      filled = false;
    }
  }
  submit.disabled = !filled;
});
