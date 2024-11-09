import { React, useEffect, useState } from 'react'
import { Button, Modal, Input, InputNumber, Form } from 'antd'
import { useModal } from '../context/ModalContext';
import axios from '../api/axios'

const { TextArea } = Input;

const ViewEditProductModal = () => {
    const { isViewModalVisible, setViewModalVisible, viewModalProductId } = useModal();

    const [productData, setProductData] = useState(null);
    const [isLoading, setIsLoading] = useState(false);
    const [isEditMode, setIsEditMode] = useState(false);

    const [form] = Form.useForm();
    const isReadOnly = true;

    useEffect(() => {
        if (viewModalProductId != null) {
            setIsLoading(true);
            fetchDataAsync();
        }
    }, [viewModalProductId]);

    const fetchDataAsync = async () => {
        try {
            const response = await axios.get(`/api/products/${viewModalProductId}`);
            console.debug(response);
            form.setFieldsValue(response.data);
            setProductData(response.data);
        }
        catch (error) {
            console.error(error);
        }
        finally {
            setIsLoading(false);
        }
    }

    const handleClose = () => {
        setViewModalVisible(false);
    }

    const ProductData = () => {
        var styles = { color: "black" };

        if (!isLoading) {
            return (
                <Form form={form} layout="vertical" className="modal-form">
                    <Form.Item name="Name" label="Название товара">
                        <TextArea readOnly={isReadOnly} size="large" style={{ fieldSizing: "content", styles }}></TextArea>
                    </Form.Item>
                    <Form.Item name="Description" label="Описание товара">
                        <TextArea readOnly={isReadOnly} size="large" style={{ fieldSizing: "content", styles }}></TextArea>
                    </Form.Item>
                    <Form.Item name="Vendorcode" label="Код товара">
                        <InputNumber readOnly={isReadOnly} size="large" />
                    </Form.Item>
                    <Form.Item name="Quantity" label="Количество на складе">
                        <InputNumber readOnly={isReadOnly} id="productQuantity" size="large" />
                    </Form.Item>
                    <Form.Item name="Price" label="Цена товара">
                        <InputNumber readOnly={isReadOnly} size="large" />
                    </Form.Item>
                </Form>
            );
        }
    }

    const FooterButtons = () => {
        return (
            <>
                <Button>Редактировать товар</Button>
                <Button key="back" onClick={handleClose}>Закрыть</Button>
            </>
        );
    }

    return (
        <Modal title="Просмотр товара"
            loading={isLoading}
            okText="Закрыть"
            open={isViewModalVisible}
            onCancel={handleClose}
            footer={FooterButtons}>
            <ProductData />
        </Modal>
    )
};

export default ViewEditProductModal;