import { Component, OnInit } from '@angular/core';
import { ContactService } from './services/contact.service';
import { ContactDTO } from './models/contact';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  public contacts: ContactDTO[] = [];

  constructor(private contactService: ContactService) { }

  ngOnInit() {
    this.getContacts();
  }

  getContacts() {
    this.contactService.getContacts().subscribe(
      (result) => {
        this.contacts = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  deleteContact(id: number) {
    this.contactService.deleteContact(id).subscribe(
      () => {
        this.contacts = this.contacts.filter(c => c.contactID !== id);
      },
      (error) => {
        console.error(error);
      }
    );
  }

  title = 'angularapp1.client';
}
