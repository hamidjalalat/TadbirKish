namespace TadbirKish.Presentation.Models
{
    public class RegistrationViewModel
    {
        public RegistrationViewModel()
        {
            CovergeViewModels = new List<CovergeViewModel>();
        }
        public string Subject { get; set; }

        public List<CovergeViewModel> CovergeViewModels { get; set; }
    }
}
