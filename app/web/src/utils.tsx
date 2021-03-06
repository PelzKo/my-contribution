import { notification } from "antd"
import * as React from "react"
import styled from "styled-components"
import { grey } from "@ant-design/colors"

export function getLocation() {
  var promise = new Promise<{ longitude: number; latitude: number }>(
    (resolve, reject) => {
      if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(location => {
          resolve({
            latitude: location.coords.latitude,
            longitude: location.coords.longitude,
          })
        })
      } else {
        notification.error({
          message: "Geolocation is not supported by this browser.",
        })
        reject("Geolocation is not supported by this browser.")
      }
    },
  )
  return promise
}

const Tr = styled.tr<{ highlight: boolean }>`
  transition: all;
  transition-duration: 1s;
  &:hover {
    background: #efefef;
    cursor: pointer;
  }
  ${props => `background: ${props.highlight ? "#efefef" : undefined}`}
`

export function HighlightableRow(props: any & { path: string }) {
  return (
    // <Popover trigger={"contextMenu"} content={<div>hello world</div>}>
    <Tr
      {...props}
      highlight={window.location.pathname.startsWith(
        `${props.path}${props["data-row-key"]}`,
      )}
    />
    // </Popover>
  )
}
