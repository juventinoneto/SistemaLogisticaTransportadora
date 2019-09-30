import { TestBed } from '@angular/core/testing';

import { ControleExpedicaoService } from './controle-expedicao.service';

describe('ControleExpedicaoService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ControleExpedicaoService = TestBed.get(ControleExpedicaoService);
    expect(service).toBeTruthy();
  });
});
