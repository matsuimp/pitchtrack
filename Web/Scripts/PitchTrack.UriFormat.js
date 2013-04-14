var PitchTrack = PitchTrack || {};
PitchTrack.UriFormat = (function () {
	return {
		modelBindEnumerable : function(values, parameterName) {
			if (!values) {
				return null;
			}

			return parameterName + "=" + values.join("&" + parameterName + "=");
		}
	};
})();