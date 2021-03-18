import type { CreateUpdateStudentDto, StudentDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class StudentService {
  apiName = 'Default';

  create = (input: CreateUpdateStudentDto) =>
    this.restService.request<any, StudentDto>({
      method: 'POST',
      url: `/api/app/student`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/student/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, StudentDto>({
      method: 'GET',
      url: `/api/app/student/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<StudentDto>>({
      method: 'GET',
      url: `/api/app/student`,
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateStudentDto) =>
    this.restService.request<any, StudentDto>({
      method: 'PUT',
      url: `/api/app/student/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
