import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ContactService } from '../services/contact.service';
import { CreateContactRequestDto } from '../models/create-contact-request';

@Component({
  selector: 'app-create-contact',
  templateUrl: './create-contact.component.html',
  styleUrls: ['./create-contact.component.css']
})
export class CreateContactComponent {

  contactDto: CreateContactRequestDto = {
    firstName: '',
    lastName: '',
    email: '',
    password: '',
    category: '',
    subCategory: '',
    phoneNumber: '',
    birthDate: new Date()
  };

  constructor(
    private router: Router,
    private contactService: ContactService
  ) { }

  createContact() {
    this.contactService.createContact(this.contactDto).subscribe(
      () => {
        console.log('Contact created successfully.');
        this.router.navigate(['/contacts']);
      },
      error => {
        console.error('Error creating contact:', error);
      }
    );
  }
}
