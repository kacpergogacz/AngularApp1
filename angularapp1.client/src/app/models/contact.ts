export interface ContactDTO {
  contactID: number;
  firstName: string;
  lastName: string;
  email: string;
  category: string;
  subCategory?: string;
  phoneNumber: string;
  birthDate: Date;
}
