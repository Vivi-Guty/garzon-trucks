import { Injectable } from '@angular/core';
import { MessageService } from 'primeng/api';

@Injectable({
  providedIn: 'root'
})
export class ErrorService {

  constructor(private messageService: MessageService) { }

  show(options: { error?: any, title?: string }) {
    if (!options) throw new Error('Argument Error. options must be provided');
    if (!options.error && !options.title) throw new Error('Argument error. error or title must be provided');
    const errorMessage = this.getErrorMessage(options.error);
    const summary = (errorMessage && options.title) || 'Problema';
    const detail = errorMessage || options.title;
    this.messageService.add({
      severity: 'error',
      summary: summary,
      detail: detail,
      closable: true,
      life: 10000,
      id: `${summary}|${detail}`
    });
  }

  getErrorMessage(error: any): string {
    if (!error) return '';
    if (error?.error?.title || error?.error?.detail) {
      return error.error.detail || error?.error?.title;
    }
    switch (error.status) {
      case 400: {
        if (error.error != undefined)
          return error.error;
        else
          return 'Datos incorrectos';
      }
      case 401: return 'No has iniciado sesión';
      case 403: return 'No tienes permiso para realizar la acción solicitada';
      case 404: return 'La entidad solicidada no existe';
      case 500: return 'Fallo en el servidor';
    }
    if (error.status === 0 || error.status === 504) {
      return 'Ha resultado imposible conectar con el servidor';
    }
    if (error.message) {
      return error.message;
    }
    return 'Fallo inesperado';
  }
}
