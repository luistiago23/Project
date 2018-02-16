import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Candidate } from '../model/candidate';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';

@Injectable()
export class ListService {

    private urlApi = 'http://localhost:9990/Home';
    private authCheckUser = false;
    private resultAuth;
    constructor (private http: Http) { }

    getAllUsers() {
        return this.http.get(this.urlApi + '/GetAllUsers')
        .map(results => this.resultAuth = results.json());
    }

    update(auth: Candidate) {
        return this.http.post(this.urlApi + '/Update', auth).toPromise()
        .then(results => this.resultAuth = results.json());
    }

    delete(id) {
        return this.http.post(this.getUserUrl(id), '')
        .map(res => res.json());
      }

      deleteT(auth: Candidate) {
        return this.http.post(this.urlApi + '/Delete', auth)
        .map(res => res.json());
      }

      private getUserUrl(id){
        return this.urlApi + "/Delete/" + id;
      }

    authCheck() {
        if (this.resultAuth.stateCode === 1) {
            this.authCheckUser = true;
        }
    }
}