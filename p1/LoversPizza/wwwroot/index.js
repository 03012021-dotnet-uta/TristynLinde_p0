let loginForm = document.getElementById('user-info');

loginForm.addEventListener('click', (event) => {
    event.preventDefault();

    const Username = loginForm.username.value.trim();
    const Password = loginForm.password.value.trim();

    fetch(`api/lovers/login/${Username}/${Password}`)
    .then(response => {
        if (!response.ok) {
          throw new Error(`Network response was not ok (${response.status})`);
        }
        else       // When the page is loaded convert it to text
          return response.json();
      })
      .then((jsonResponse) => {
        responseDiv.textContent = `Welcome, ${jsonResponse.fname} ${jsonResponse.lname}. It's good to see you.`;
        console.log(jsonResponse);
        return jsonResponse;
      })
      .then(res => {
        //save the Person to localStorage
        localStorage.setItem('customer', JSON.stringify(res));
        //sessionStorage.setItem('personId', res.personId);
        //switch the screen
        location = 'menu.html';
      })
      .catch(function(err) {  
          console.log('Failed to fetch page: ', err);  
      });
});