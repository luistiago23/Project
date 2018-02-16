import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RegisterService } from './register.service';
import { Candidate } from '../model/candidate';
import { ActivatedRoute } from '@angular/router';
import { SelectItem } from 'primeng/primeng';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Message } from 'primeng/components/common/api';
import { MessageService } from 'primeng/components/common/messageservice';

@Component({
  selector: 'app-root',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class RegisterComponent implements OnInit {

  private candidate: Candidate = new Candidate();
  aba: string = 'part1';
  activatedRoute: ActivatedRoute;
  idUpdate: number;
  skillLevel: SelectItem[];
  formulario: any;
  formPartOne: any;
  formPartTwo: any;
  formPartThree: any;
  msgs: Message[] = [];

  constructor(
    private router: Router,
    private repository: RegisterService,
    activatedRoute: ActivatedRoute,
    private formBuilder: FormBuilder,
    private messageService: MessageService
  ) {
    this.activatedRoute = activatedRoute;
    this.activatedRoute.params.subscribe(params => {
      this.idUpdate = params['id'];
    })

    this.skillLevel = [
      { label: '0', value: 0 },
      { label: '1', value: 1 },
      { label: '2', value: 2 },
      { label: '3', value: 3 },
      { label: '4', value: 4 },
      { label: '5', value: 5 },
    ];

    this.formPartOne = this.formBuilder.group({
      'Email': [null, Validators.required],
      'Skype': [null, Validators.required],
      'Phone': [null, Validators.required],
      'Linkedin': [],
      'City': [null, Validators.required],
      'State': [null, Validators.required],
      'Portfolio': [],
      'SalaryRequirement': [null, Validators.required],
      'BankInformation': [null],
      formWorkHours: new FormGroup({
        UpToFourHours: new FormControl(null),
        FourToSix: new FormControl(null),
        SixToEight: new FormControl(null),
        UpToEight: new FormControl(null),
        OnlyWeekends: new FormControl(null),
      }, this.CheckGroupValidation),
      formBestTime: new FormGroup({
        Morning: new FormControl(null),
        Afternoon: new FormControl(null),
        Night: new FormControl(null),
        Dawn: new FormControl(null),
        Business: new FormControl(null),
      }, this.CheckGroupValidation)
    }),
      this.formPartTwo = this.formBuilder.group({
        'Business': [null],
        'Name': [null],
        'Cpf': [null],
        'Bank': [null],
        'Agency': [null],
        'AccountNumber': [null],
        AccountType: new FormGroup({
          Chain: new FormControl(null),
          Savings: new FormControl(null),
        }, this.CheckGroupValidation)
      })
    this.formPartThree = this.formBuilder.group({
      'Ionic': [null],
      'Android': [null],
      'Ios': [null],
      'Html': [null],
      'Css': [null],
      'Bootstrap': [null],
      'Jquery': [null],
      'AngularJs': [null],
      'java': [null],
      'AspNet': [null],
      'C': [null],
      'CPlusPlus': [null],
      'Cake': [null],
      'DJango': [null],
      'Majento': [null],
      'Php': [null],
      'Wordpress': [null],
      'Phyton': [null],
      'Ruby': [null],
      'MySqlServer': [null],
      'MySql': [null],
      'SalesForce': [null],
      'Photoshop': [null],
      'Illustrator': [null],
      'Seo': [null],
      'OtherTechnology': [null],
      'LinkCrud': [null]
    })
  }

  ngOnInit() {
    let upToFourHours = document.getElementById('someSwitchOptionDefault');
    if (this.idUpdate != undefined || this.idUpdate != null) {
      this.repository.getUsersById(this.idUpdate).subscribe(users => {
        this.candidate = users;
      });
    }
  }

  private CheckGroupValidation(group: FormGroup) {

    var valid = false;
    var control_name: any;


    for (control_name in group.controls) {
      var check = group.controls[control_name].value;
      if (check) { valid = true; break; }
    }

    if (valid) { return null; }
    return { CheckGroupValidation: true };
  }

  saveData() {
    if (this.idUpdate != null && this.candidate != null) {debugger;
      this.repository.update(this.candidate).subscribe(() => {
        this.router.navigate(['/list']);
      });
    } else {debugger;
      this.repository.save(this.candidate).subscribe(response => {
        debugger;
        if (response != "email in use") {
          this.router.navigate(['/list']);
        } else {
          this.error()
        }
      })
    }
  }
  error() {
    this.messageService.add({ severity: 'error', summary: 'Error', detail: 'Email de usuário em uso' });
  }
}
