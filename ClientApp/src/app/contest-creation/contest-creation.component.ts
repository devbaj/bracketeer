import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-contest-creation',
  templateUrl: './contest-creation.component.html',
  styleUrls: ['./contest-creation.component.scss']
})
export class ContestCreationComponent implements OnInit {
  contest = {
    title: 'TEST CONTEST',
    maxContestant: 64
  };

  constructor(
    private _httpService: HttpService
  ) { }

  ngOnInit() {
  }

  fireTestData() {
    console.log('Test data fired - component');
    const observable = this._httpService.runPostTest(this.contest);
    observable.subscribe(payload => {
      console.log(payload);
    });
  }

}
