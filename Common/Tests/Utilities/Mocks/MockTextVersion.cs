﻿//*********************************************************//
//    Copyright (c) Microsoft. All rights reserved.
//    
//    Apache 2.0 License
//    
//    You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//    
//    Unless required by applicable law or agreed to in writing, software 
//    distributed under the License is distributed on an "AS IS" BASIS, 
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or 
//    implied. See the License for the specific language governing 
//    permissions and limitations under the License.
//
//*********************************************************//

using System;
using Microsoft.VisualStudio.Text;

namespace TestUtilities.Mocks {
    public class MockTextVersion : ITextVersion {
        private readonly int _version;
        internal readonly MockTextSnapshot _snapshot;
        private MockTextVersion _nextVersion;
        private INormalizedTextChangeCollection _changes;
        
        public MockTextVersion(int version, MockTextSnapshot snapshot) {
            _version = version;
            _snapshot = snapshot;
        }

        /// <summary>
        /// changes to get to the next version
        /// </summary>
        public INormalizedTextChangeCollection Changes {
            get {
                return _changes;
            }
        }

        public ITrackingSpan CreateCustomTrackingSpan(Span span, TrackingFidelityMode trackingFidelity, object customState, CustomTrackToVersion behavior) {
            throw new NotImplementedException();
        }

        public ITrackingPoint CreateTrackingPoint(int position, PointTrackingMode trackingMode, TrackingFidelityMode trackingFidelity) {
            throw new NotImplementedException();
        }

        public ITrackingPoint CreateTrackingPoint(int position, PointTrackingMode trackingMode) {
            throw new NotImplementedException();
        }

        public ITrackingSpan CreateTrackingSpan(int start, int length, SpanTrackingMode trackingMode, TrackingFidelityMode trackingFidelity) {
            throw new NotImplementedException();
        }

        public ITrackingSpan CreateTrackingSpan(int start, int length, SpanTrackingMode trackingMode) {
            throw new NotImplementedException();
        }

        public ITrackingSpan CreateTrackingSpan(Span span, SpanTrackingMode trackingMode, TrackingFidelityMode trackingFidelity) {
            throw new NotImplementedException();
        }

        public ITrackingSpan CreateTrackingSpan(Span span, SpanTrackingMode trackingMode) {
            throw new NotImplementedException();
        }

        public int Length {
            get { return _snapshot.Length; }
        }

        public ITextVersion Next {
            get { return _nextVersion; }
        }

        public int ReiteratedVersionNumber {
            get { throw new NotImplementedException(); }
        }

        public ITextBuffer TextBuffer {
            get { return _snapshot.TextBuffer; }
        }

        public int VersionNumber {
            get { return _version; }
        }

        internal void SetNext(MockTextVersion nextVersion, params ITextChange[] changes) {
            _nextVersion = nextVersion;
            _changes = new MockNormalizedTextChangeCollection(changes);
        }
    }
}
