export interface CourseRegistration {
  id: number;
  courseName: string;
  studentName: string;
  email: string;
  phone: string;
  gender: string;
  subscription:boolean
  registrationDate: Date;
}
