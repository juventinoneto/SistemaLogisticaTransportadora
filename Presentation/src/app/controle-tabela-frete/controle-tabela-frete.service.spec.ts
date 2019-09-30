import { TestBed } from '@angular/core/testing';

import { ControleTabelaFreteService } from './controle-tabela-frete.service';

describe('ControleTabelaFreteService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ControleTabelaFreteService = TestBed.get(ControleTabelaFreteService);
    expect(service).toBeTruthy();
  });
});
