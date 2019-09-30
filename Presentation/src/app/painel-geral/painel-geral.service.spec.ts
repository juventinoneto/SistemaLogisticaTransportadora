import { TestBed } from '@angular/core/testing';

import { PainelGeralService } from './painel-geral.service';

describe('PainelGeralService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PainelGeralService = TestBed.get(PainelGeralService);
    expect(service).toBeTruthy();
  });
});
