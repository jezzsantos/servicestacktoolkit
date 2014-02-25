using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;

namespace ServiceStackToolkit.Automation.ValueProviders
{
    public abstract class ExpressionConverterProvider : NuPattern.Runtime.ValueProvider
    {
        private static readonly ITracer tracer = Tracer.Get<ExpressionConverterProvider>();

        /// <summary>
        /// Gets or sets the expression to convert to lower case.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [DisplayName(@"Expression")]
        [Description(@"The expression to convert.")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the current element.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IProductElement CurrentElement
        {
            get;
            set;
        }

        /// <summary>
        /// Converts the value of the expression 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract string ConvertExpressedValue(string value);

        /// <summary>
        /// Returns the provided result.
        /// </summary>
        /// <remarks></remarks>
        public override object Evaluate()
        {
            this.ValidateObject();

            tracer.Info(
                "Evaluating ExpressionConverterProvider on current element '{0}' with Expression '{1}'", this.CurrentElement.InstanceName, this.Expression);

            var result = ExpressionEvaluator.Evaluate(this.CurrentElement, this.Expression);
            if (!string.IsNullOrEmpty(result))
            {
                result = ConvertExpressedValue(result);
            }

            tracer.Info(
                "Evaluated ExpressionConverterProvider on current element '{0}' with Expression '{1}', as '{2}'", this.CurrentElement.InstanceName, this.Expression, result);

            return result;
        }

    }
}
