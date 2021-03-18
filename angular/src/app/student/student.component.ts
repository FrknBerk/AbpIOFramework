import { Component, OnInit } from '@angular/core';
import { ListService,PagedResultDto} from '@abp/ng.core';
import { StudentService,StudentDto} from '@proxy/students';
import { FormGroup, FormBuilder, Validators} from '@angular/forms';
import { ConfirmationService,Confirmation} from '@abp/ng.theme.shared';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.scss'],
  providers:[ListService],
}) 
export class StudentComponent implements OnInit {
  students  = { items:[], totalCount:0} as PagedResultDto<StudentDto>;
 
  selectedStudent = {} as StudentDto;

  form :FormGroup;

  isModalOpen = false;

  constructor(public readonly list:ListService,private studentService:StudentService, private fb: FormBuilder, private confirmation: ConfirmationService) { }

  ngOnInit(): void {
    const studentStreamCreator = (query) => this.studentService.getList(query);

    this.list.hookToQuery(studentStreamCreator).subscribe((response) => {
      this.students = response;
      console.log(this.students);
    });
  }

  createStudent(){
    this.buildForm();
    this.isModalOpen=true;
  }

  editStudent(id: string){
    this.studentService.get(id).subscribe((student) => {
      this.selectedStudent = student;
      this.buildForm();
      this.isModalOpen=true;
    });
  }

  delete(id: string){
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) =>{
      if(status === Confirmation.Status.confirm){
        this.studentService.delete(id).subscribe(() => this.list.get());
      }
    })
  }
  
  buildForm(){
    this.form =this.fb.group({
      firstName : [this.selectedStudent.firstName || '',Validators.required],
      lastName: [ this.selectedStudent.lastName || null,Validators.required],
      phone: [ this.selectedStudent.phone || null,Validators.required],
    });
  }

  save(){
    if(this.form.invalid){
      return;
    }

    const request = this.selectedStudent.id ? this.studentService.update(this.selectedStudent.id,this.form.value) : this.studentService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen=false;
      this.form.reset();
      this.list.get();
    })
  }

}
