/*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 *//*!
 * MediaElement.js
 * http://www.mediaelementjs.com/
 *
 * Wrapper that mimics native HTML5 MediaElement (audio and video)
 * using a variety of technologies (pure JavaScript, Flash, iframe)
 *
 * Copyright 2010-2017, John Dyer (http://j.hn/)
 * License: MIT
 *
 */(function e(t,n,r){function s(o,u){if(!n[o]){if(!t[o]){var a=typeof require=="function"&&require;if(!u&&a)return a(o,!0);if(i)return i(o,!0);var f=new Error("Cannot find module '"+o+"'");throw f.code="MODULE_NOT_FOUND",f}var l=n[o]={exports:{}};t[o][0].call(l.exports,function(e){var n=t[o][1][e];return s(n?n:e)},l,l.exports,e,t,n,r)}return n[o].exports}var i=typeof require=="function"&&require;for(var o=0;o<r.length;o++)s(r[o]);return s})({1:[function(_dereq_,module,exports){
'use strict';

Object.assign(mejs.MepDefaults, {
	adsUrl: ''
});

Object.assign(MediaElementPlayer.prototype, {
	buildgoogleima: function buildgoogleima(player, controls, layers, media) {

		if (!player.options.adsUrl) {
			return;
		}

		player.imaLayer = document.createElement('div');
		player.imaLayer.id = player.options.classPrefix + 'ads';
		player.imaLayer.className = player.options.classPrefix + 'overlay ' + player.options.classPrefix + 'layer ' + player.options.classPrefix + 'ima-layer';
		layers.insertBefore(player.imaLayer, layers.firstChild);

		player.playingAds = false;
		player.adsActive = false;
		player.preloadListener = null;

		player.contentCompleteCalled = false;

		mejs.Utils.loadScript('https://imasdk.googleapis.com/js/sdkloader/ima3.js').then(function () {
			google.ima.settings.setVpaidMode(google.ima.ImaSdkSettings.VpaidMode.ENABLED);

			player.adsManager = null;
			player.adsDone = false;
			player.adDisplayContainer = new google.ima.AdDisplayContainer(player.imaLayer, media);
			player.adsLoader = new google.ima.AdsLoader(player.adDisplayContainer);
			player.adsLoader.addEventListener(google.ima.AdsManagerLoadedEvent.Type.ADS_MANAGER_LOADED, player.onAdsManagerLoaded_.bind(player));

			player.adsLoader.addEventListener(google.ima.AdErrorEvent.Type.AD_ERROR, player.onAdError_.bind(player));

			player.resizeAdsCallback = function () {
				if (player.adsManager) {
					player.adsManager.resize(player.container.offsetWidth, player.container.offsetHeight, google.ima.ViewMode.NORMAL);
				}
			};

			player.originalPlayCallback = player.play;
			player.originalPauseCallback = player.pause;

			media.addEventListener('ended', player.contentEndedListener_.bind(player));
			player.play = player.playAds_.bind(player);
			player.pause = player.playAds_.bind(player);

			player.globalBind('resize', player.resizeAdsCallback);
		});
	},
	cleangoogleima: function cleangoogleima(player, controls, layers, media) {
		media.removeEventListener('ended', player.contentEndedListener_.bind(player));
		media.removeEventListener('play', player.playAds_.bind(player));
		media.removeEventListener('pause', player.playAds_.bind(player));
		player.globalUnbind('resize', player.resizeAdsCallback);
		player.imaLayer.remove();
	},
	loadAds_: function loadAds_() {
		var t = this;
		if (t.preloadListener) {
			t.media.removeEventListener('loadedmetadata', t.loadAds_.bind(t));
			t.preloadListener = null;
		}
		t.requestAds_(t.options.adsUrl);
	},
	contentEndedListener_: function contentEndedListener_() {
		this.contentCompleteCalled = true;
		this.adsLoader.contentComplete();
		this.imaLayer.style.display = 'none';
		this.play = this.originalPlayCallback();
		this.pause = this.originalPauseCallback();
	},
	playAds_: function playAds_() {
		var t = this;

		if (!t.adsDone) {
			t.adDisplayContainer.initialize();
			t.load();

			if (t.paused && (mejs.Features.isAndroid || mejs.Features.isIOS)) {
				t.preloadListener = t.loadAds_();
				t.media.addEventListener('loadedmetadata', t.loadAds_.bind(t));
				t.media.load();
			} else {
				t.loadAds_();
			}
			t.adsDone = true;
			return;
		}

		if (t.adsActive) {
			var event = void 0;

			if (t.playingAds && t.adsManager) {
				t.adsManager.pause();
				t.playingAds = false;
				event = mejs.Utils.createEvent('pause', t.media);
			} else if (t.adsManager) {
				t.adsManager.resume();
				t.playingAds = true;
				event = mejs.Utils.createEvent('play', t.media);
			}
			t.media.dispatchEvent(event);
		}
	},
	requestAds_: function requestAds_(adTagUrl) {
		var t = this;
		t.adsRequest = new google.ima.AdsRequest();

		t.adsRequest.adTagUrl = adTagUrl;
		t.adsRequest.linearAdSlotWidth = t.container.offsetWidth;
		t.adsRequest.linearAdSlotHeight = t.container.offsetHeight;
		t.adsRequest.nonLinearAdSlotWidth = t.container.offsetWidth;
		t.adsRequest.nonLinearAdSlotHeight = t.container.offsetHeight;
		t.adsLoader.requestAds(t.adsRequest);
	},
	onAdsManagerLoaded_: function onAdsManagerLoaded_(adsManagerLoadedEvent) {
		var t = this,
		    adsRenderingSettings = new google.ima.AdsRenderingSettings();
		adsRenderingSettings.restoreCustomPlaybackStateOnAdBreakComplete = true;
		t.adsManager = adsManagerLoadedEvent.getAdsManager(t.media, adsRenderingSettings);

		t.adsManager.addEventListener(google.ima.AdErrorEvent.Type.AD_ERROR, t.onAdError_.bind(t));
		t.adsManager.addEventListener(google.ima.AdEvent.Type.CONTENT_PAUSE_REQUESTED, t.onContentPauseRequested_.bind(t));
		t.adsManager.addEventListener(google.ima.AdEvent.Type.CONTENT_RESUME_REQUESTED, t.onContentResumeRequested_.bind(t));
		var events = [google.ima.AdEvent.Type.ALL_ADS_COMPLETED, google.ima.AdEvent.Type.CLICK, google.ima.AdEvent.Type.COMPLETE, google.ima.AdEvent.Type.FIRST_QUARTILE, google.ima.AdEvent.Type.LOADED, google.ima.AdEvent.Type.MIDPOINT, google.ima.AdEvent.Type.PAUSED, google.ima.AdEvent.Type.STARTED, google.ima.AdEvent.Type.THIRD_QUARTILE];
		for (var i = 0, total = events.length; i < total; i++) {
			t.adsManager.addEventListener(events[i], t.onAdEvent_.bind(t));
		}

		t.adsManager.init(t.container.offsetWidth, t.container.offsetHeight, google.ima.ViewMode.NORMAL);
		t.resetSize();
		t.adsManager.start();
	},
	onAdEvent_: function onAdEvent_(adEvent) {
		var t = this,
		    ad = adEvent.getAd();
		if (adEvent.type === google.ima.AdEvent.Type.LOADED) {
			if (!ad.isLinear()) {
				t.onContentResumeRequested_();
			}
		} else if (adEvent.type === google.ima.AdEvent.Type.CLICK) {
			t.onContentPauseRequested_();
		}
	},
	onAdError_: function onAdError_(adErrorEvent) {
		console.error(adErrorEvent.getError());
		this.adsManager.destroy();
		this.cleangoogleima(this, this.controls, this.layers, this.media);
	},
	onContentPauseRequested_: function onContentPauseRequested_() {
		this.media.removeEventListener('ended', this.contentEndedListener_.bind(this));
		this.adsActive = true;
		this.playingAds = true;
		this.pause();
	},
	onContentResumeRequested_: function onContentResumeRequested_() {
		var _this = this;

		this.media.addEventListener('ended', this.contentEndedListener_.bind(this));
		if (!this.contentCompleteCalled) {
			this.adsActive = false;
			this.imaLayer.style.display = 'none';

			this.play = function () {
				return _this.originalPlayCallback.call(_this);
			};
			this.pause = function () {
				return _this.originalPauseCallback.call(_this);
			};
			this.play();
		}
	}
});

},{}]},{},[1]);
