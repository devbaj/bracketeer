import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  public createNewContest(data: any) {
    return this._http.post('/api/contest/create', data);
  }

  public runPostTest(data: any) {
    console.log('test data fired - service');
    return this._http.post('/api/post/test', data);
  }
}
