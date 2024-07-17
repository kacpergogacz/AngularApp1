import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactsListComponent } from './contact-list.component';

describe('ContactListComponent', () => {
  let component: ContactsListComponent;
  let fixture: ComponentFixture<ContactsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ContactsListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ContactsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
