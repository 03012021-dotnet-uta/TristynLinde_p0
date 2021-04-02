const registerForm = document.getElementById('register');

registerForm.confirmPassword.addEventListener('input', () => {
  if (registerForm.confirmPassword.value != registerForm.password.value) {
    registerForm.confirmPassword.setCustomValidity("Passwords must match");
    registerForm.confirmPassword.reportValidity(); // Shows the popup bubble
  }
  else {
    registerForm.confirmPassword.setCustomValidity("");
  }
})

registerForm.addEventListener('submit', (event) => {
  event.preventDefault();//to prevent the form from submitting and resetting

  // grab the data and create an object to send as part of the body of my fetch()
  // console.log(registerForm.fname.value);
  const userData = {
    fname: registerForm.firstname.value.trim(),
    lname: registerForm.lastname.value.trim(),
    username: registerForm.username.value.trim(),
    password: registerForm.password.value.trim(),
  }

  fetch('api/Lovers/register', {
    method: 'POST',
    headers: {
      'Accept': 'application/json',
      'Content-Type':'application/json'
    },
    body:JSON.stringify(userData)
    })
    .then(response => {
      if (!response.ok) {
        throw new Error(`Network response was not ok (${response.status})`);
      }
      else       // When the page is loaded convert it to text
        return response.json();
    })
    .then((jsonResponse) => {
      console.log(jsonResponse);
      return jsonResponse;
    })
    .then(res => {
      //save the customer and id to localStorage
      let cust = JSON.stringify(res);
      localStorage.setItem('customer', cust);
      localStorage.setItem('customerId', res.customerId);
      //switch the screen
      location = 'menu.html';
    })
    .catch(function(err) {  
        console.log('Failed to fetch page: ', err);  
    });
});
