import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateStudentDto {
  firstName: string;
  lastName: string;
  phone: string;
}

export interface StudentDto extends AuditedEntityDto<string> {
  firstName?: string;
  lastName?: string;
  phone?: string;
}
