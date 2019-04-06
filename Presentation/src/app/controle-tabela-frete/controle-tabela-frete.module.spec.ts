import { ControleTabelaFreteModule } from './controle-tabela-frete.module';

describe('ControleTabelaFreteModule', () => {
  let controleTabelaFreteModule: ControleTabelaFreteModule;

  beforeEach(() => {
    controleTabelaFreteModule = new ControleTabelaFreteModule();
  });

  it('should create an instance', () => {
    expect(controleTabelaFreteModule).toBeTruthy();
  });
});
