import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  public createNewContest(data: any) {
    let body: string = JSON.stringify(data);
    return this._http.post('/api/contest/create', body);
  }

  public runPostTest(data: any) {
    console.log('test data fired - service');
    var body = {content: JSON.stringify(data)};
    console.log(body);
    return this._http.post('/api/post/test', body);
  }
}
