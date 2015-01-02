using System;
using System.IO;
using System.Web.Mvc;

namespace SuperScript.Container.Mvc
{
    public abstract class BaseContainer : IDisposable
    {
        protected internal readonly string EmitterKey;
        protected internal readonly int? InsertAt;
        protected internal readonly WebViewPage WebPage;


        /// <summary>
        /// Create a new using block from the given helper (used for trapping appropriate context)
        /// </summary>
        /// <param name="helper">
        /// The helper from which we use the context.
        /// </param>
        /// <param name="emitterKey">
        /// <para>Indicates which instance of <see cref="SuperScript.Emitters.IEmitter"/> the content should be added to.</para>
        /// <para>If not specified then the contents will be added to the default implementation of <see cref="SuperScript.Emitters.IEmitter"/>.</para>
        /// </param>
        /// <param name="insertAt">
        /// Indicates the index in the collection at which the contents are to be inserted.
        /// </param>
        protected BaseContainer(HtmlHelper helper, string emitterKey, int? insertAt)
        {
            EmitterKey = emitterKey;
            InsertAt = insertAt;
            WebPage = (WebViewPage) helper.ViewDataContainer;

            // start a new writing context
            WebPage.OutputStack.Push(new StringWriter());
        }


        /// <summary>
        /// Append the internal content to the context's cached list of output delegates
        /// </summary>
        public abstract void Dispose();
    }
}