import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Candidate } from '../model/candidate';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';

@Injectable()
export class RegisterService {

    private urlApi = 'http://localhost:9990/Home';
    private authCheckUser = false;
    private resultAuth;
    constructor (private http: Http) { }

    getUsersById(id) {
        return this.http.post(this.getUserUrlUsers(id), '')
        .map(results => results.json());
    }

    save(auth: Candidate) {debugger;
        return this.http.post(this.urlApi + '/SaveArray', auth)
        .map(results => this.resultAuth = results.json());
    }

    update(auth: Candidate) {debugger;
        return this.http.post(this.urlApi + '/Update', auth)
        .map(results => this.resultAuth = results.json());
    }

      private getUserUrlUsers(id){
        return this.urlApi + "/GetUsersById/" + id;
      }

    authCheck() {
        if (this.resultAuth.stateCode === 1) {
            this.authCheckUser = true;
        }
    }

    // /Service of Validation///

    getValidatorErrorMessage(validatorName: string, validatorValue?: any) {
        let config = {
            'required': 'Campo necessário',
            'invalidCreditCard': 'Is invalid credit card number',
            'invalidEmailAddress': 'Invalid email address',
            'invalidPassword': 'Invalid password. Password must be at least 6 characters long, and contain a number.',
            'minlength': `Minimum length ${validatorValue.requiredLength}`
        };

        return config[validatorName];
    }
}