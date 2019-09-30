import { TestBed } from '@angular/core/testing';

import { ControleColetaDefinicaoCargaService } from './controle-coleta-definicao-carga.service';

describe('ControleColetaDefinicaoCargaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ControleColetaDefinicaoCargaService = TestBed.get(ControleColetaDefinicaoCargaService);
    expect(service).toBeTruthy();
  });
});
