import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { ContactDTO } from '../models/contact';
import { ContactService } from '../services/contact.service';

@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html',
  styleUrls: ['./contact-details.component.css']
})
export class ContactDetailsComponent implements OnInit {

  contact: ContactDTO = {
    contactID: 0,
    firstName: '',
    lastName: '',
    email: '',
    category: '',
    subCategory: '',
    phoneNumber: '',
    birthDate: new Date()
  };
  constructor(
    private route: ActivatedRoute,
    private contactService: ContactService,
    private location: Location
  ) { }

  ngOnInit(): void {
    this.loadContact();
  }

  loadContact() {
    const id = this.route.snapshot.paramMap.get('id');
    if (id != null) {
      const idParam = + id;
      this.contactService.getContactById(idParam).subscribe(
        contact => {
          this.contact = contact;
        },
        error => {
          console.error('Error loading contact:', error);
        }
      );
    }
  }

  saveChanges() {
    this.contactService.updateContact(this.contact.contactID, this.contact).subscribe(
      () => {
        console.log('Contact updated successfully.');
      },
      error => {
        console.error('Error updating contact:', error);
      }
    );
  }

  deleteContact() {
    this.contactService.deleteContact(this.contact.contactID).subscribe(
      () => {
        console.log('Contact deleted successfully.');
        this.location.back(); // powrót
      },
      error => {
        console.error('Error deleting contact:', error);
      }
    );
  }
}
