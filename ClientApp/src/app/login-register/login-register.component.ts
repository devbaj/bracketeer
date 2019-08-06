import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';
import { UserService } from '../user.service';

@Component({
  selector: 'app-login-register',
  templateUrl: './login-register.component.html',
  styleUrls: ['./login-register.component.scss']
})
export class LoginRegisterComponent implements OnInit {
  newUser = {
    GivenName: '',
    Surname: '',
    Username: '',
    Email: '',
    Birthdate: Date.now
  };

  constructor(
    private _httpService: HttpService,
    private _userService: UserService
  ) { }

  ngOnInit() {
  }

  onSubmit() {
   let observable = this._httpService.registerNewUser(this.newUser);
   observable.subscribe(res => {
     if (res[`success`]) { this._userService.userID = res[`UserID`]; }
     else { console.log('Errors ' + res[`msg`]); }
   });
  }

}
