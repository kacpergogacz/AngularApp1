import { Component, OnInit } from '@angular/core';
import { ContactDTO } from '../models/contact';
import { ContactService } from '../services/contact.service';
import { Router } from '@angular/router'; // Upewnij się, że Router jest zaimportowany

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.css']
})
export class ContactsListComponent implements OnInit {

  contacts: ContactDTO[] = [];

  constructor(
    private contactService: ContactService,
    private router: Router // Dodaj Router do konstruktora
  ) { }

  ngOnInit(): void {
    this.loadContacts();
  }

  loadContacts() {
    this.contactService.getContacts().subscribe(
      contacts => {
        this.contacts = contacts;
      },
      error => {
        console.error('Error loading contacts:', error);
      }
    );
  }

  navigateToAddContact() {
    this.router.navigate(['/contacts/add']); // Sprawdź, czy ta metoda jest poprawnie zadeklarowana i dostępna
  }
}
