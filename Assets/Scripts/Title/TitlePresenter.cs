namespace Title
{
    public class TitlePresenter : Presenter<TitleModel, TitleView>
    {
        public TitlePresenter(TitleModel model, TitleView view) : base(model, view)
        {
        }

        public override void BindToModel()
        {
            
        }

        public override void BindToView()
        {
            View.Map1Button.onClick.AddListener(Model.OpenMap1);
        }
    }
}
