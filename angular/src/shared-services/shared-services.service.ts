import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import * as fileSaver from 'file-saver';

@Injectable({
    providedIn: 'root'
})
export class SharedServicesService {

    constructor() { }

    /**Esta sacado de PrimerNG */
    saveAsExcelFile(buffer: any, fileName: string): void {
      let EXCEL_TYPE = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';
      let EXCEL_EXTENSION = '.xlsx';
      const data: Blob = new Blob([buffer], {
          type: EXCEL_TYPE
      });
      fileSaver.saveAs(data, fileName + '_' + new Date().getTime() + EXCEL_EXTENSION);
  }
}
