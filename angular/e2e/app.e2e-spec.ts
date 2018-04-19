import { abcnowTemplatePage } from './app.po';

describe('abcnow App', function() {
  let page: abcnowTemplatePage;

  beforeEach(() => {
    page = new abcnowTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
