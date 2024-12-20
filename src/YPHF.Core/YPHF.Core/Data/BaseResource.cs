/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

namespace YPHF.Core.Data
{
    /// <summary>
    /// Class BaseResource.
    /// </summary>
    public class BaseResource
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; set; } = default!;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the operations.
        /// </summary>
        /// <value>The operations.</value>
        public List<BaseOperation> Operations { get; set; } = default!;

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        /// <value>The sequence.</value>
        public int Sequence { get; set; } = default!;
    }
}