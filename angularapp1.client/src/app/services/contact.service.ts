import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { CreateContactRequestDto } from '../models/create-contact-request';
import { ContactDTO } from '../models/contact';
@Injectable({
  providedIn: 'root'
})
export class ContactService {

  private apiUrl = environment.apiBaseUrl + '/contacts';

  constructor(private http: HttpClient) { }

  getContacts(): Observable<ContactDTO[]> {
    return this.http.get<ContactDTO[]>(`${this.apiUrl}`);
  }

  getContactById(id: number): Observable<ContactDTO> {
    return this.http.get<ContactDTO>(`${this.apiUrl}/${id}`);
  }

  createContact(contactDto: CreateContactRequestDto): Observable<ContactDTO> {
    return this.http.post<ContactDTO>(`${this.apiUrl}`, contactDto);
  }

  updateContact(id: number, contactDto: ContactDTO): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/${id}`, contactDto);
  }

  deleteContact(id: number): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/${id}`);
  }
}
