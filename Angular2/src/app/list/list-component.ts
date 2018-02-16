import { Component, OnInit } from '@angular/core';
import { ListService } from './list.service';
import { Candidate } from '../model/candidate';
import { Router } from '@angular/router';
import {Message} from 'primeng/components/common/api';
import {MessageService} from 'primeng/components/common/messageservice';

@Component ({
    selector: 'list-component',
    templateUrl: './list-component.html',
    styleUrls: ['./list-component.css'],
    providers: [MessageService]
})

export class ListComponent implements OnInit {

    private candidate: Candidate[] = [];
    msgs: Message[] = [];
    
    constructor (private repository: ListService,
                 private router: Router,
                 private messageService: MessageService
                ) {}

    ngOnInit() {
        this.repository.getAllUsers().subscribe(allUsers =>
            this.candidate = allUsers
        )
    }
    deleteUsers(id) {
        this.repository.delete(id).subscribe( () => {
            let index = this.candidate.findIndex(x => x.ID === id);
            this.candidate.splice(index,1);
            this.showSuccess()
        });
    }

    showSuccess() {
        this.msgs = [];
        this.msgs.push({severity:'success', summary:'Operação bem sucedida', detail:'objeto deletado'});
    }

    checkList() {
        this.repository.getAllUsers().subscribe(allUsers =>
            this.candidate = allUsers
        )
    }
}