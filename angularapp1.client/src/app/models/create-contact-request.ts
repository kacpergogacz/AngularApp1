export interface CreateContactRequestDto {
  firstName: string;
  lastName: string;
  email: string;
  password: string;
  category: string;
  subCategory?: string;
  phoneNumber: string;
  birthDate: Date;
}
